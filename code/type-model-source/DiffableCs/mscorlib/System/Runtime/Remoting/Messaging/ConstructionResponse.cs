namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
[Token(Token = "0x20003B2")]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
{

	[Token(Token = "0x17000342")]
	public virtual IDictionary Properties
	{
		[Address(RVA = "0x1F00530", Offset = "0x1EFF930", Length = "0xBB")]
		[Token(Token = "0x6001CB7")]
		 get { } //Length: 187
	}

	[Address(RVA = "0x1F003C0", Offset = "0x1EFF7C0", Length = "0xBB")]
	[Token(Token = "0x6001CB4")]
	internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	[Address(RVA = "0x1F00480", Offset = "0x1EFF880", Length = "0x8")]
	[Token(Token = "0x6001CB5")]
	internal ConstructionResponse(Exception e, IMethodCallMessage msg) { }

	[Address(RVA = "0x1F00490", Offset = "0x1EFF890", Length = "0x91")]
	[Token(Token = "0x6001CB6")]
	internal ConstructionResponse(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F00530", Offset = "0x1EFF930", Length = "0xBB")]
	[Token(Token = "0x6001CB7")]
	public virtual IDictionary get_Properties() { }

}

