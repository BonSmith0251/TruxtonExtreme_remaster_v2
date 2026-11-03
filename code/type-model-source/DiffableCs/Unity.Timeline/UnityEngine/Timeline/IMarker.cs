namespace UnityEngine.Timeline;

[Token(Token = "0x2000042")]
public interface IMarker
{

	[Token(Token = "0x170000B8")]
	public TrackAsset parent
	{
		[Token(Token = "0x6000278")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B7")]
	public double time
	{
		[Token(Token = "0x6000276")]
		 get { } //Length: 0
		[Token(Token = "0x6000277")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000278")]
	public TrackAsset get_parent() { }

	[Token(Token = "0x6000276")]
	public double get_time() { }

	[Token(Token = "0x6000279")]
	public void Initialize(TrackAsset parent) { }

	[Token(Token = "0x6000277")]
	public void set_time(double value) { }

}

