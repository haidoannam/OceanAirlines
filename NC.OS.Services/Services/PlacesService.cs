using NC.OS.Data.Infrastructure;
using NC.OS.Data.Repositories;
using NC.OS.Entites;
using NC.OS.Model;
using NC.OS.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Services.Services
{
    public class PlacesService : IPlacesService
    {
        private readonly IEntityBaseRepository<Places> _placesRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PlacesService(IEntityBaseRepository<Places> placesRepository, IUnitOfWork unitOfWork)
        {
            _placesRepository = placesRepository;
            _unitOfWork = unitOfWork;
        }

        public IList<PlacesModel> LoadAllPlaces()
        {
            return _placesRepository.GetAll()
                .Select(x => new PlacesModel { Id = x.Id, Name = x.Name })
                .ToList();
        }
    }
}
