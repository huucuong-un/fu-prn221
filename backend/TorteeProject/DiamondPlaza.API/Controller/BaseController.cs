using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiamondPlaze.Service;

namespace DiamondPlaze.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TEntity> : ControllerBase where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseService;

        public BaseController(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            try
            {
                var entities = await _baseService.GetAllAsync();
                return Ok(entities);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetById(Guid id)
        {
            try
            {
                var entity = await _baseService.GetByIdAsync(id);
                if (entity == null)
                {
                    return NotFound();
                }

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Create(TEntity entity)
        {
            try
            {
                await _baseService.AddAsync(entity);
                return CreatedAtAction(nameof(GetById), new { id = (entity as dynamic).Id }, entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, TEntity entity)
        {
            if (id != (entity as dynamic).Id)
            {
                return BadRequest("Entity ID mismatch");
            }

            try
            {
                var existingEntity = await _baseService.GetByIdAsync(id);
                if (existingEntity == null)
                {
                    return NotFound();
                }

                await _baseService.UpdateAsync(entity);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var entity = await _baseService.GetByIdAsync(id);
                if (entity == null)
                {
                    return NotFound();
                }

                await _baseService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
