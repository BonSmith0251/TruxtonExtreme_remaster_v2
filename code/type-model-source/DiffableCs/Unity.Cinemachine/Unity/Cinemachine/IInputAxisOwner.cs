namespace Unity.Cinemachine;

[Token(Token = "0x20000C0")]
public interface IInputAxisOwner
{
	[Token(Token = "0x20000C1")]
	internal struct AxisDescriptor
	{
		[Token(Token = "0x20000C2")]
		internal sealed class AxisGetter : MulticastDelegate
		{

			[Address(RVA = "0x17C9ED0", Offset = "0x17C92D0", Length = "0xA5")]
			[Token(Token = "0x60003B6")]
			public AxisGetter(object object, IntPtr method) { }

			[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
			[Token(Token = "0x60003B8")]
			public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

			[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
			[Token(Token = "0x60003B9")]
			public override InputAxis EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
			[Token(Token = "0x60003B7")]
			public override InputAxis Invoke() { }

		}

		[Token(Token = "0x20000C3")]
		internal enum Hints : int
		{
			Default = 0,
			X = 1,
			Y = 2,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E7")]
		public AxisGetter DrivenAxis; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002E8")]
		public string Name; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002E9")]
		public Hints Hint; //Field offset: 0x10

	}


	[Token(Token = "0x60003B5")]
	public void GetInputAxes(List<AxisDescriptor> axes) { }

}

