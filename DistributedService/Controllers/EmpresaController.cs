﻿using Application.Cadastro.Dto;
using Application.Cadastro.Modules.EmpresaModule.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("v1/empresa")]
    [ApiController]
    [Authorize]
    public class EmpresaController : ControllerBase, IGenericController<EmpresaDto, long>
    {
        private readonly IEmpresaService _empresaService;
        private readonly ILogger<EmpresaController> _logger;

        public EmpresaController(IEmpresaService empresaService, ILogger<EmpresaController> logger)
        {
            _empresaService = empresaService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get(long id)
        {
            var retorno = await _empresaService.Get(id);

            if (retorno.IsValid)
            {
                return BadRequest(retorno);
            }

            return Ok(retorno);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var retorno = await _empresaService.GetAll();

            if (retorno.IsValid)
            {
                return BadRequest(retorno);
            }

            return Ok(retorno);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmpresaDto empresaDto)
        {
            var retorno = await _empresaService.Create(empresaDto);

            if (retorno.IsValid)
            {
                return Ok(retorno);
            }

            return BadRequest(retorno);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(IEnumerable<EmpresaDto> empresasDto)
        {
            var retorno = await _empresaService.Create(empresasDto);

            if (retorno.IsValid)
            {
                return Ok(retorno);
            }

            return BadRequest(retorno);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            var retorno = await _empresaService.Delete(id);

            if (retorno.IsValid)
            {
                return Ok(retorno);
            }

            return BadRequest(retorno);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(IEnumerable<EmpresaDto> empresasDto)
        {
            var retorno = await _empresaService.Delete(empresasDto);

            if (retorno.IsValid)
            {
                return Ok(retorno);
            }

            return BadRequest(retorno);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(EmpresaDto empresasDto)
        {
            var retorno = await _empresaService.Delete(empresasDto);

            if (retorno.IsValid)
            {
                return Ok(retorno);
            }

            return BadRequest(retorno);
        }

        [HttpPut]
        public async Task<IActionResult> Update(IEnumerable<EmpresaDto> empresasDto)
        {
            var retorno = await _empresaService.Update(empresasDto);

            if (retorno.IsValid)
            {
                return Ok(retorno);
            }

            return BadRequest(retorno);
        }

        [HttpPut]
        public async Task<IActionResult> Update(EmpresaDto empresaDto)
        {
            var retorno = await _empresaService.Update(empresaDto);

            if (retorno.IsValid)
            {
                return Ok(retorno);
            }

            return BadRequest(retorno);
        }
    }
}