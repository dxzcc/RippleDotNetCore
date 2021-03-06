﻿using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Shared.Transactions
{
    public class BookOffer : OfferCreate
    {
        public IAmount TakerGetsFunded { get; set; }
        public IAmount TakerPaysFunded { get; set; }
        public decimal? Quality { get; set; }
    }
}
