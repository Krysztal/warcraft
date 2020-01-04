﻿using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A bonus list
    /// </summary>
    public class BonusList
    {
        /// <summary>
        /// Gets or sets the bonus list ID.
        /// </summary>
        [JsonProperty("bonusListId")]
        public int BonusListId { get; set; }

    }
}
