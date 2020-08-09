﻿using Taxi.Common.Models;
using Taxi.web.Data.Entities;


namespace Taxi.Web.Helpers
{
    public interface IConverterHelper
    {
        TaxiResponse ToTaxiResponse(TaxiEntity taxiEntity);
    }
}

