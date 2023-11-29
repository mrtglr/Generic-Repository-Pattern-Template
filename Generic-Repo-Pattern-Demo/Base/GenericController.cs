using Generic_Repo_Pattern_Demo.Base.Interfaces;
using Generic_Repo_Pattern_Demo.Context;
using Microsoft.AspNetCore.Mvc;

namespace Generic_Repo_Pattern_Demo.Base
{
    public class GenericController<TEntity> : ControllerBase, IController<TEntity> where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repository;

        public GenericController(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("Create")]
        public async Task Create([FromBody] TEntity entity)
        {
            await _repository.Create(entity);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }

        [HttpGet]
        [Route("Get")]
        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<TEntity> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(Guid id, [FromBody] TEntity entity)
        {
            await _repository.Update(id, entity);
        }
    }
}
