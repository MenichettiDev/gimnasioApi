using System.Threading.Tasks;
using gimnasioApi.Dtos;
using gimnasioApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace gimnasioApi.Services.Interfaces
{
    public interface IAtencionService
    {
        Task<IActionResult> ObtenerAtenciones(int page, int pageSize);
        Task<IActionResult> ObtenerAtencionPorId(int id);
        Task<IActionResult> CrearAtencionAsync(CrearAtencionDto dto, int barberoId);
        Task<IActionResult> ActualizarAtencion(int id, ActualizarAtencionDto dto);
        Task<IActionResult> EliminarAtencion(int id);
        Task<IActionResult> ObtenerResumenBarbero(int barberoId, int mes, int anio);
    }
}
