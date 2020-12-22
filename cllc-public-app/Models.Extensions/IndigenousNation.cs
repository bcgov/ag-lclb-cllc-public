﻿using Gov.Lclb.Cllb.Interfaces.Models;

namespace Gov.Lclb.Cllb.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class IndigenousNationExtensions
    {
        /// <summary>
        /// Convert a given voteQuestion to a ViewModel
        /// </summary>        
        public static ViewModels.IndigenousNation ToViewModel(this MicrosoftDynamicsCRMadoxioLocalgovindigenousnation item)
        {
            ViewModels.IndigenousNation result = null;
            if (item != null)
            {
                result = new ViewModels.IndigenousNation
                {
                    Id = item.AdoxioLocalgovindigenousnationid,
                    Name = item.AdoxioName
                };


            }
            return result;
        }
    }
}
