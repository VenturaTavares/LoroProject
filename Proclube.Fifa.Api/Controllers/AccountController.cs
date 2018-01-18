using AutoMapper;
using Proclube.Fifa.Api.Models;
using Proclube.Fifa.Domain.Infraestrutura;
using Proclube.Fifa.Domain.Models;
using Proclube.Fifa.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Proclube.Fifa.Api.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : BaseController
    {
        #region Declare

        private UsuarioRepository _UsuarioRepository;
        private MapperConfiguration ConfigMap;
        private IMapper iMapper;
        const string USER_NOT_VALID_MESSAGE = "Usuário ou Senha inválidos";
        const string EMAIL_NOT_VALID_MESSAGE = "E-mail não cadastrado";

        #endregion

        #region CTOR
        public AccountController()
        {
            response = new BaseResponse();
            formatter = new JsonMediaTypeFormatter();
            responseCode = new System.Net.HttpStatusCode();

            ConfigMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UsuarioViewModel, Usuario>();
                cfg.CreateMap<Usuario, UsuarioViewModel>();
            });

            iMapper = ConfigMap.CreateMapper();
            _UsuarioRepository = new UsuarioRepository(new ProclubeContext());
        }
        #endregion

        #region Public Methods

        [HttpPost]
        [Route("RegistrarParticipante")]
        public async Task<UsuarioViewModel> RegistrarParticipante(UsuarioViewModel usuario)
        {

            try
            {
                //if (!ModelState.IsValid)
                //    return Request.CreateResponse(HttpStatusCode.InternalServerError);

                //var _participante = iMapper.Map<ParticipanteViewModel, Participante>(participante);

                //var returnParticipante = await _participanteRepository.RegistrarParticipante(_participante);

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return usuario;
        }

        [HttpPost]
        [Route("AlterarParticipante")]
        public async Task<UsuarioViewModel> AlterarParticipante(UsuarioViewModel usuario)
        {

            try
            {
                //if (!ModelState.IsValid)
                //    return Request.CreateResponse(HttpStatusCode.InternalServerError);

                //var _participante = iMapper.Map<ParticipanteViewModel, Participante>(participante);

                //var returnParticipante = await _participanteRepository.RegistrarParticipante(_participante);

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return usuario;
        }


        [HttpPost]
        [Route("AlterarSenha")]
        public async Task<System.Net.Http.HttpResponseMessage> AlterarSenha(string SenhaNova, string SenhaNovaConfirm, string SenhaAntiga)
        {

            try
            {
                //if (!ModelState.IsValid)
                //    return Request.CreateResponse(HttpStatusCode.InternalServerError);

                //var _participante = iMapper.Map<ParticipanteViewModel, Participante>(participante);

                //var returnParticipante = await _participanteRepository.RegistrarParticipante(_participante);

                if (SenhaNova != SenhaNovaConfirm)
                {

                    return Request.CreateResponse(HttpStatusCode.ExpectationFailed);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return Request.CreateResponse(HttpStatusCode.OK, MontarUsuario());
        }



        [HttpPost]
        [Route("ObterParticipante")]
        public async Task<System.Net.Http.HttpResponseMessage> ObterParticipante(UsuarioViewModel usuario)
        {

            UsuarioViewModel user = new UsuarioViewModel();

            user = this.MontarUsuario();

            return Request.CreateResponse(HttpStatusCode.OK, usuario);

        }


        private UsuarioViewModel MontarUsuario()
        {

            UsuarioViewModel UserFake = new UsuarioViewModel();

            using (var rep = new UsuarioRepository(new ProclubeContext()))
            {

                Usuario user = rep.MontarUsuario();

                UserFake = iMapper.Map<Usuario, UsuarioViewModel>(user);


            }

            return UserFake;
        }

        [HttpGet]
        [Route("LogarParticipante")]
        public async Task<UsuarioViewModel> LogarParticipante(string login_email, string senha)
        {

            UsuarioViewModel usuario = new UsuarioViewModel();
            try
            {
                usuario.Email = login_email;
                usuario.Nome = login_email;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            usuario = MontarUsuario();

            return usuario;
        }



        #endregion
    }
}