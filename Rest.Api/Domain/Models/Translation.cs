using System.Text.Json.Serialization;

namespace Domain.Model
{
    public class Translation
    { /// <summary>
      /// Official name.
      /// </summary>
        [JsonPropertyName("official")]
        public string Official { get; set; }

        /// <summary>
        /// Common used name.
        /// </summary>
        [JsonPropertyName("common")]
        public string Common { get; set; }


    }

    /// <summary>
    /// https://iso639-3.sil.org/code/{code}
    /// </summary>
    public  class TranslationLanguage
    {
        /// <summary>
        /// Arabic language.
        /// </summary>
        public  string Arabic = "arb";

        /// <summary>
        /// Breton language.
        /// </summary>
        public  string Breton = "bre";

        /// <summary>
        /// Czech language.
        /// </summary>
        public  string Czech = "ces";

        /// <summary>
        /// Welsh language.
        /// </summary>
        public  string Welsh = "cym";

        /// <summary>
        /// German language.
        /// </summary>
        public  string German = "deu";

        /// <summary>
        /// Estonian language.
        /// </summary>
        public  string Estonian = "est";

        /// <summary>
        /// Finnish language.
        /// </summary>
        public  string Finnish = "fin";

        /// <summary>
        /// French language.
        /// </summary>
        public  string French = "fra";

        /// <summary>
        /// Croatian language.
        /// </summary>
        public  string Croatian = "hrv";

        /// <summary>
        /// Hungarian language.
        /// </summary>
        public  string Hungarian = "hun";

        /// <summary>
        /// Italian language.
        /// </summary>
        public  string Italian = "ita";

        /// <summary>
        /// Japanese language.
        /// </summary>
        public  string Japanese = "jpn";

        /// <summary>
        /// Korean language.
        /// </summary>
        public  string Korean = "kor";

        /// <summary>
        /// Dutch language.
        /// </summary>
        public  string Dutch = "nld";

        /// <summary>
        /// Persian language.
        /// </summary>
        public  string Persian = "per";

        /// <summary>
        /// Polish language.
        /// </summary>
        public  string Polish = "pol";

        /// <summary>
        /// Russian language.
        /// </summary>
        public  string Russian = "rus";

        /// <summary>
        /// Slovak language.
        /// </summary>
        public  string Slovak = "slk";

        /// <summary>
        /// Spanish language.
        /// </summary>
        public  string Spanish = "spa";

        /// <summary>
        /// Swedish language.
        /// </summary>
        public  string Swedish = "swe";

        /// <summary>
        /// Turkish language.
        /// </summary>
        public  string Turkish = "tur";
        /// <summary>
        /// Urdu language.
        /// </summary>
        public  string Urdu = "urd";

        /// <summary>
        /// Chinese language.
        /// </summary>
        public  string Chinese = "zho";
    }
}

