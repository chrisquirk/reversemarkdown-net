
namespace ReverseMarkdown
{
	public class Config
	{
		private UnknownTagsOption _unknownTags = UnknownTagsOption.PassThrough;
		private bool _githubFlavored = false;
		private bool _textNotMarkdown = false;
        private bool _compressNewlines = true;
		
		public Config()
		{
		}

		public Config(UnknownTagsOption unknownTags=UnknownTagsOption.PassThrough, bool githubFlavored=false, bool textNotMarkdown=false, bool compressNewlines = true)
		{
			this._unknownTags = unknownTags;
			this._githubFlavored = githubFlavored;
            this._textNotMarkdown = textNotMarkdown;
            this._compressNewlines = compressNewlines;
		}

		public UnknownTagsOption UnknownTags
		{
			get { return this._unknownTags; }
		}

		public bool GithubFlavored
		{
			get { return this._githubFlavored; }
		}

        public bool TextNotMarkdown
        {
			get { return this._textNotMarkdown; }
        }

        public bool CompressNewlines
        {
            get { return this._compressNewlines; }
        }

        public enum UnknownTagsOption
        {
            PassThrough,
            Drop,
            Bypass,
            Raise
        }
	}
}
