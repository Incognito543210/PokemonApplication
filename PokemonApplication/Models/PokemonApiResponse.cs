using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokemonApplication.Models
{
    //Response api for one pokemon
    public class PokemonApiResponse
    {
        [JsonPropertyName("abilities")]
        public PokemonApiResponseAbility[] Abilities { get; set; }
        [JsonPropertyName("base_experience ")]
        public int Base_experience { get; set; }
        [JsonPropertyName("cries")]
        public PokemonApiResponseCries Cries { get; set; }
        [JsonPropertyName("forms")]
        public PokemonApiResponseForm[] Forms { get; set; }
        [JsonPropertyName("game_indices")]
        public PokemonApiResponseGame_Indices[] Game_indices { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("held_items")]
        public object[] Held_items { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("is_default")]
        public bool Is_default { get; set; }
        [JsonPropertyName("location_area_encounters")]
        public string Location_area_encounters { get; set; }
        [JsonPropertyName("moves")]
        public PokemonApiResponseMove[] Moves { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("order")]
        public int Order { get; set; }
        [JsonPropertyName("past_abilities")]
        public object[] Past_abilities { get; set; }
        [JsonPropertyName("past_types")]
        public object[] Past_types { get; set; }
        [JsonPropertyName("species")]
        public PokemonApiResponseSpecies Species { get; set; }
        [JsonPropertyName("sprites")]
        public PokemonApiResponseSprites Sprites { get; set; }
        [JsonPropertyName("stats")]
        public PokemonApiResponseStat[] Stats { get; set; }
        [JsonPropertyName("types")]
        public PokemonApiResponseType[] Types { get; set; }
        [JsonPropertyName("weight")]
        public int Weight { get; set; }

    }






    public class PokemonApiResponseCries
    {
        public string latest { get; set; }
        public string legacy { get; set; }
    }

    public class PokemonApiResponseSpecies
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonApiResponseSprites
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
        public Other other { get; set; }
        public Versions versions { get; set; }
    }

    public class Other
    {
        public PokemonApiResponseDream_World dream_world { get; set; }
        public Home home { get; set; }
        public OfficialArtwork officialartwork { get; set; }
        public Showdown showdown { get; set; }
    }

    public class PokemonApiResponseDream_World
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class Home
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class OfficialArtwork
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class Showdown
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Versions
    {
        public GenerationI generationi { get; set; }
        public GenerationIi generationii { get; set; }
        public GenerationIii generationiii { get; set; }
        public GenerationIv generationiv { get; set; }
        public GenerationV generationv { get; set; }
        public GenerationVi generationvi { get; set; }
        public GenerationVii generationvii { get; set; }
        public GenerationViii generationviii { get; set; }
    }

    public class GenerationI
    {
        public RedBlue redblue { get; set; }
        public Yellow yellow { get; set; }
    }

    public class RedBlue
    {
        public string back_default { get; set; }
        public string back_gray { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_gray { get; set; }
        public string front_transparent { get; set; }
    }

    public class Yellow
    {
        public string back_default { get; set; }
        public string back_gray { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_gray { get; set; }
        public string front_transparent { get; set; }
    }

    public class GenerationIi
    {
        public Crystal crystal { get; set; }
        public Gold gold { get; set; }
        public Silver silver { get; set; }
    }

    public class Crystal
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_transparent { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_transparent { get; set; }
        public string front_transparent { get; set; }
    }

    public class Gold
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_transparent { get; set; }
    }

    public class Silver
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_transparent { get; set; }
    }

    public class GenerationIii
    {
        public Emerald emerald { get; set; }
        public FireredLeafgreen fireredleafgreen { get; set; }
        public RubySapphire rubysapphire { get; set; }
    }

    public class Emerald
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class FireredLeafgreen
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class RubySapphire
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class GenerationIv
    {
        public DiamondPearl diamondpearl { get; set; }
        public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
        public Platinum platinum { get; set; }
    }

    public class DiamondPearl
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Platinum
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationV
    {
        public BlackWhite blackwhite { get; set; }
    }

    public class BlackWhite
    {
        public Animated animated { get; set; }
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Animated
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationVi
    {
        public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }
        public XY xy { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class XY
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationVii
    {
        public Icons icons { get; set; }
        public UltraSunUltraMoon ultrasunultramoon { get; set; }
    }

    public class Icons
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class UltraSunUltraMoon
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationViii
    {
        public Icons1 icons { get; set; }
    }

    public class Icons1
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class PokemonApiResponseAbility
    {
        public Ability1 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Ability1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonApiResponseForm
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonApiResponseGame_Indices
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonApiResponseMove
    {
        public Move1 move { get; set; }
        public Version_Group_Details[] version_group_details { get; set; }
    }

    public class Move1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Group_Details
    {
        public int level_learned_at { get; set; }
        public Move_Learn_Method move_learn_method { get; set; }
        public Version_Group version_group { get; set; }
    }

    public class Move_Learn_Method
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Group
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonApiResponseStat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat1 stat { get; set; }
    }

    public class Stat1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonApiResponseType
    {
        public int slot { get; set; }
        public Type1 type { get; set; }
    }

    public class Type1
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
