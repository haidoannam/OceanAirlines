using NC.OS.Entites;
using NC.OS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Services.Interface
{
    public interface IPlacesService
    {
        IList<PlacesModel> LoadAllPlaces();
    }
}
