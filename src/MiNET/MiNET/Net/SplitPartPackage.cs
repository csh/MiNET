namespace MiNET.Net
{
	public class SplitPartPackage : Package<SplitPartPackage>
	{
		public byte[] Message { get; set; }
		public int SplitId { get; set; }
		public int SplitCount { get; set; }
		public int SplitIdx { get; set; }

		public SplitPartPackage()
		{
		}

		public override void Reset()
		{
			base.Reset();
			Message = null;
		}
	}
}