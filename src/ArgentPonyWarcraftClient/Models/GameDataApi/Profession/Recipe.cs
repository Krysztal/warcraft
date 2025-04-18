﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A recipe.
    /// </summary>
    public record Recipe
    {
        /// <summary>
        /// Gets links for the recipe.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; init; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets the name of the recipe.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// Gets the description of the recipe.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// Gets the media associated with the recipe.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; init; }

        /// <summary>
        /// Gets a reference to the item crafted by this recipe.
        /// </summary>
        [JsonPropertyName("crafted_item")]
        public ItemReference CraftedItem { get; init; }

        /// <summary>
        /// Gets the reagents required for the recipe.
        /// </summary>
        [JsonPropertyName("reagents")]
        public RecipeReagent[] Reagents { get; init; }

        /// <summary>
        /// Gets the range of item quantities produced by this recipe.
        /// </summary>
        [JsonPropertyName("crafted_quantity")]
        public CraftedQuantity CraftedQuantity { get; init; }
    }
}
