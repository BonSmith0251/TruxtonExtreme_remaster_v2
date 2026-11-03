namespace UnityEngine.UIElements;

[Token(Token = "0x20004CC")]
internal interface IUIElementsUtility
{

	[Token(Token = "0x600248B")]
	public bool CleanupRoots() { }

	[Token(Token = "0x600248C")]
	public bool EndContainerGUIFromException(Exception exception) { }

	[Token(Token = "0x600248D")]
	public bool MakeCurrentIMGUIContainerDirty() { }

	[Token(Token = "0x600248A")]
	public bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	[Token(Token = "0x6002489")]
	public bool ReleaseCapture() { }

	[Token(Token = "0x6002488")]
	public bool TakeCapture() { }

}

