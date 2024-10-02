using Captcha.Application.DTO;
using Captcha.Domain.Entities;
using Captcha.Domain.Exceptions;
using Captcha.Domain.Interfaces;
using Mapster;

namespace Captcha.Application.Services;

public class MousePositionDataService(IRepository<MousePositionData> repository)
{
    private readonly IRepository<MousePositionData> _repository = repository;

    public virtual async Task AddAsync(MousePositionDataDTO dto)
    {
        var entity = dto.Adapt<MousePositionData>();
        await _repository.AddEntity(entity);
    }


    public virtual async Task<ICollection<MousePositionDataDTO>> GetAllAsync()
    {
        var entities =  await _repository.GetAllEntitiesAsync();
        return entities.Adapt<ICollection<MousePositionDataDTO>>();
    }

    public virtual async Task<MousePositionDataDTO> GetAsync(Guid id)
    {
        var entity = await repository.GetEntityByIdAsync(id) ?? throw new NullEntityException($"can't find entity by given id: {id}");
        return entity.Adapt<MousePositionDataDTO>();
    }

    public virtual async Task UpdateAsync(MousePositionDataDTO dto)
    {
        var entity = await _repository.GetEntityByIdAsync(dto.Id) ?? throw new NullEntityException($"can't find entity by given id: {dto.Id}");
        dto.Adapt(entity);
        await _repository.UpdateEntity(entity);
        await _repository.SaveChangesAsync();

    }

    public virtual async Task DeleteAsync(Guid id)
    {
        var entity = await repository.GetEntityByIdAsync(id) ?? throw new NullEntityException($"can't find entity by given id: {id}");
        await repository.DeleteEntity(entity);
    }

}
