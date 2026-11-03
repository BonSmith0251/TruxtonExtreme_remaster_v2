namespace UnityEngine.UIElements;

[Token(Token = "0x2000569")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal interface IVisualTreeUpdater : IDisposable
{

	[Token(Token = "0x17000A26")]
	public long FrameCount
	{
		[Token(Token = "0x6002768")]
		 get { } //Length: 0
		[Token(Token = "0x6002769")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000A27")]
	public BaseVisualElementPanel panel
	{
		[Token(Token = "0x600276A")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000A28")]
	public ProfilerMarker profilerMarker
	{
		[Token(Token = "0x600276B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002768")]
	public long get_FrameCount() { }

	[Token(Token = "0x600276B")]
	public ProfilerMarker get_profilerMarker() { }

	[Token(Token = "0x600276D")]
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Token(Token = "0x6002769")]
	public void set_FrameCount(long value) { }

	[Token(Token = "0x600276A")]
	public void set_panel(BaseVisualElementPanel value) { }

	[Token(Token = "0x600276C")]
	public void Update() { }

}

