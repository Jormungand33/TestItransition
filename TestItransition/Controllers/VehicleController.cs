using CollectionsProject;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Text.Json;
using TestItransition.Exceptions;

namespace TestItransition.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;

        public VehicleController(ILogger<VehicleController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// ���������� � ������������� ������ ����������
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InitializationException"></exception>
        [HttpPost]
        [Route("initializationException")]
        public async Task<IActionResult> InitializationException()
        {
            throw new InitializationException();
        }
        /// <summary>
        /// ���������� ����� ������ ���������� 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="AddException"></exception>
        [HttpPost]
        [Route("addException")]
        public async Task<IActionResult> AddException()
        {
            throw new AddException();
        }
        /// <summary>
        ///  ��������� ������  ����������
        /// </summary>
        /// <param name="parameter">��������</param>
        /// <param name="value">��������</param>
        /// <returns></returns>
        /// <exception cref="GetAutoByParameterException"></exception>
        [HttpGet]
        [Route("getAutoByParameterException")]
        public async Task<IActionResult> GetAutoByParameterException(
            string parameter = "",
            string value = "")
        {
            throw new GetAutoByParameterException();
        }
        /// <summary>
        ///  ���������� ������ � ����������
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <exception cref="UpdateAutoException"></exception>
        [HttpPut]
        [Route("updateAutoException")]
        public async Task<IActionResult> UpdateAutoException(Guid ID)
        {
            throw new UpdateAutoException();
        }
        /// <summary>
        ///  �������� ������ � ���������� 
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <exception cref="RemoveAutoException"></exception>
        [HttpDelete]
        [Route("removeAutoException")]
        public async Task<IActionResult> RemoveAutoException(Guid ID)
        {
            throw new RemoveAutoException();
        }
    }
}