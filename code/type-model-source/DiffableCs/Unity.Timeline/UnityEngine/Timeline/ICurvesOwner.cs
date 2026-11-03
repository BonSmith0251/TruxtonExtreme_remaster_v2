namespace UnityEngine.Timeline;

[Token(Token = "0x2000017")]
internal interface ICurvesOwner
{

	[Token(Token = "0x17000033")]
	public object asset
	{
		[Token(Token = "0x60000AD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000034")]
	public object assetOwner
	{
		[Token(Token = "0x60000AE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002F")]
	public AnimationClip curves
	{
		[Token(Token = "0x60000A8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000032")]
	public string defaultCurvesName
	{
		[Token(Token = "0x60000AC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000031")]
	public double duration
	{
		[Token(Token = "0x60000AA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000030")]
	public bool hasCurves
	{
		[Token(Token = "0x60000A9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000035")]
	public TrackAsset targetTrack
	{
		[Token(Token = "0x60000AF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60000AB")]
	public void CreateCurves(string curvesClipName) { }

	[Token(Token = "0x60000AD")]
	public object get_asset() { }

	[Token(Token = "0x60000AE")]
	public object get_assetOwner() { }

	[Token(Token = "0x60000A8")]
	public AnimationClip get_curves() { }

	[Token(Token = "0x60000AC")]
	public string get_defaultCurvesName() { }

	[Token(Token = "0x60000AA")]
	public double get_duration() { }

	[Token(Token = "0x60000A9")]
	public bool get_hasCurves() { }

	[Token(Token = "0x60000AF")]
	public TrackAsset get_targetTrack() { }

}

