﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<ProfessionsIndex>> GetProfessionsIndexAsync(string @namespace)
        {
            return await GetProfessionsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ProfessionsIndex>> GetProfessionsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ProfessionsIndex>(region, $"{host}/data/wow/profession/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Profession>> GetProfessionAsync(int professionId, string @namespace)
        {
            return await GetProfessionAsync(professionId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Profession>> GetProfessionAsync(int professionId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Profession>(region, $"{host}/data/wow/profession/{professionId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<ProfessionMedia>> GetProfessionMediaAsync(int professionId, string @namespace)
        {
            return await GetProfessionMediaAsync(professionId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ProfessionMedia>> GetProfessionMediaAsync(int professionId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ProfessionMedia>(region, $"{host}/data/wow/media/profession/{professionId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<SkillTier>> GetSkillTierAsync(int professionId, int skillTierId, string @namespace)
        {
            return await GetSkillTierAsync(professionId, skillTierId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<SkillTier>> GetSkillTierAsync(int professionId, int skillTierId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<SkillTier>(region, $"{host}/data/wow/profession/{professionId}/skill-tier/{skillTierId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId, string @namespace)
        {
            return await GetRecipeAsync(recipeId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Recipe>(region, $"{host}/data/wow/recipe/{recipeId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<RecipeMedia>> GetRecipeMediaAsync(int recipeId, string @namespace)
        {
            return await GetRecipeMediaAsync(recipeId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<RecipeMedia>> GetRecipeMediaAsync(int recipeId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<RecipeMedia>(region, $"{host}/data/wow/media/recipe/{recipeId}?namespace={@namespace}&locale={locale}");
        }
    }
}
