namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Modules/Animation/Animation.h")]
[Token(Token = "0x2000006")]
public sealed class Animation : Behaviour, IEnumerable
{
	[Token(Token = "0x2000007")]
	private sealed class Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000008")]
		private Animation m_Outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000009")]
		private int m_CurrentIndex; //Field offset: 0x18

		[Token(Token = "0x17000001")]
		public override object Current
		{
			[Address(RVA = "0x2FC1DC0", Offset = "0x2FC11C0", Length = "0x85")]
			[Token(Token = "0x600001C")]
			 get { } //Length: 133
		}

		[Address(RVA = "0x2536CB0", Offset = "0x25360B0", Length = "0x38")]
		[Token(Token = "0x600001B")]
		internal Enumerator(Animation outer) { }

		[Address(RVA = "0x2FC1DC0", Offset = "0x2FC11C0", Length = "0x85")]
		[Token(Token = "0x600001C")]
		public override object get_Current() { }

		[Address(RVA = "0x2FC1D20", Offset = "0x2FC1120", Length = "0x90")]
		[Token(Token = "0x600001D")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
		[Token(Token = "0x600001E")]
		public override void Reset() { }

	}


	[Address(RVA = "0x2FB4280", Offset = "0x2FB3680", Length = "0x67")]
	[Token(Token = "0x6000014")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2FB4330", Offset = "0x2FB3730", Length = "0x83")]
	[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000015")]
	internal AnimationState GetStateAtIndex(int index) { }

	[Address(RVA = "0x2FB42F0", Offset = "0x2FB36F0", Length = "0x40")]
	[Token(Token = "0x6000019")]
	private static AnimationState GetStateAtIndex_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x2FB4400", Offset = "0x2FB3800", Length = "0x76")]
	[NativeName("GetAnimationStateCount")]
	[Token(Token = "0x6000016")]
	internal int GetStateCount() { }

	[Address(RVA = "0x2FB43C0", Offset = "0x2FB37C0", Length = "0x33")]
	[Token(Token = "0x600001A")]
	private static int GetStateCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FB4550", Offset = "0x2FB3950", Length = "0x78")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000011")]
	public bool Play() { }

	[Address(RVA = "0x2FB44C0", Offset = "0x2FB38C0", Length = "0x83")]
	[Token(Token = "0x6000012")]
	public bool Play(PlayMode mode) { }

	[Address(RVA = "0x2FB44C0", Offset = "0x2FB38C0", Length = "0x83")]
	[NativeName("Play")]
	[Token(Token = "0x6000013")]
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[Address(RVA = "0x2FB4480", Offset = "0x2FB3880", Length = "0x40")]
	[Token(Token = "0x6000018")]
	private static bool PlayDefaultAnimation_Injected(IntPtr _unity_self, PlayMode mode) { }

	[Address(RVA = "0x2FB4610", Offset = "0x2FB3A10", Length = "0x76")]
	[Token(Token = "0x6000010")]
	public void Stop() { }

	[Address(RVA = "0x2FB45D0", Offset = "0x2FB39D0", Length = "0x33")]
	[Token(Token = "0x6000017")]
	private static void Stop_Injected(IntPtr _unity_self) { }

}

