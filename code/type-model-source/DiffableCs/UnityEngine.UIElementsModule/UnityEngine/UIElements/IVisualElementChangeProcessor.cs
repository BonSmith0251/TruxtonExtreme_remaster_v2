namespace UnityEngine.UIElements;

[Token(Token = "0x200000B")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
internal interface IVisualElementChangeProcessor
{

	[Token(Token = "0x600002C")]
	public void BeginProcessing(BaseVisualElementPanel panel) { }

	[Token(Token = "0x600002E")]
	public void EndProcessing(BaseVisualElementPanel panel) { }

	[Token(Token = "0x600002D")]
	public void ProcessChanges(BaseVisualElementPanel panel, AuthoringChanges changes) { }

}

