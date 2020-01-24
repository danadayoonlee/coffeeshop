using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    public interface IMenuItem
    {
        [JsonProperty("Description")]
        string Description
        {
            get; set;
        }
        [JsonProperty("BaseCost")]
        decimal BaseCost
        {
            get; set;
        }
    }
}
