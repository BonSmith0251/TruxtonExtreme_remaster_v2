namespace UnityEngine.UIElements;

[Token(Token = "0x20000EA")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal interface IEditableElement
{

	[Token(Token = "0x1700010C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Action editingEnded
	{
		[Token(Token = "0x6000707")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x1700010B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Action editingStarted
	{
		[Token(Token = "0x6000706")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x6000707")]
	internal Action get_editingEnded() { }

	[Token(Token = "0x6000706")]
	internal Action get_editingStarted() { }

}

