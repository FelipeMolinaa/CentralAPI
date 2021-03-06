using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MolasWorks.Training.APICentral.Models
{
    public class PublicAPIResponse
    {
        public int count { get; set; }
        public List<APIEntity> entries { get; set; }
    }
}
