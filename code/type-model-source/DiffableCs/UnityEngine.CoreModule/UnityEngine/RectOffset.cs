namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.h")]
[Token(Token = "0x20000CA")]
[UsedByNativeCode]
public class RectOffset : IFormattable
{
	[Token(Token = "0x20000CB")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000601")]
		public static IntPtr ConvertToNative(RectOffset rectOffset) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400024C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024D")]
	private readonly object m_SourceStyle; //Field offset: 0x18

	[NativeProperty("bottom", False, TargetType::Field (1))]
	[Token(Token = "0x17000109")]
	public int bottom
	{
		[Address(RVA = "0x3010490", Offset = "0x300F890", Length = "0x51")]
		[Token(Token = "0x60005F1")]
		 get { } //Length: 81
		[Address(RVA = "0x3010850", Offset = "0x300FC50", Length = "0x58")]
		[Token(Token = "0x60005F2")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700010A")]
	public int horizontal
	{
		[Address(RVA = "0x3010530", Offset = "0x300F930", Length = "0x51")]
		[Token(Token = "0x60005F3")]
		 get { } //Length: 81
	}

	[NativeProperty("left", False, TargetType::Field (1))]
	[Token(Token = "0x17000106")]
	public int left
	{
		[Address(RVA = "0x30105D0", Offset = "0x300F9D0", Length = "0x51")]
		[Token(Token = "0x60005EB")]
		 get { } //Length: 81
		[Address(RVA = "0x30108F0", Offset = "0x300FCF0", Length = "0x58")]
		[Token(Token = "0x60005EC")]
		 set { } //Length: 88
	}

	[NativeProperty("right", False, TargetType::Field (1))]
	[Token(Token = "0x17000107")]
	public int right
	{
		[Address(RVA = "0x3010670", Offset = "0x300FA70", Length = "0x51")]
		[Token(Token = "0x60005ED")]
		 get { } //Length: 81
		[Address(RVA = "0x3010990", Offset = "0x300FD90", Length = "0x58")]
		[Token(Token = "0x60005EE")]
		 set { } //Length: 88
	}

	[NativeProperty("top", False, TargetType::Field (1))]
	[Token(Token = "0x17000108")]
	public int top
	{
		[Address(RVA = "0x3010710", Offset = "0x300FB10", Length = "0x51")]
		[Token(Token = "0x60005EF")]
		 get { } //Length: 81
		[Address(RVA = "0x3010A30", Offset = "0x300FE30", Length = "0x58")]
		[Token(Token = "0x60005F0")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700010B")]
	public int vertical
	{
		[Address(RVA = "0x30107B0", Offset = "0x300FBB0", Length = "0x51")]
		[Token(Token = "0x60005F4")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x3010410", Offset = "0x300F810", Length = "0x3B")]
	[Token(Token = "0x60005E2")]
	public RectOffset() { }

	[Address(RVA = "0x3010260", Offset = "0x300F660", Length = "0x43")]
	[Token(Token = "0x60005E3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal RectOffset(object sourceStyle, IntPtr source) { }

	[Address(RVA = "0x30102B0", Offset = "0x300F6B0", Length = "0x152")]
	[Token(Token = "0x60005E5")]
	public RectOffset(int left, int right, int top, int bottom) { }

	[Address(RVA = "0x300FCC0", Offset = "0x300F0C0", Length = "0x50")]
	[Token(Token = "0x60005E8")]
	private void Destroy() { }

	[Address(RVA = "0x300FD10", Offset = "0x300F110", Length = "0x9C")]
	[Token(Token = "0x60005E4")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3010490", Offset = "0x300F890", Length = "0x51")]
	[Token(Token = "0x60005F1")]
	public int get_bottom() { }

	[Address(RVA = "0x3010450", Offset = "0x300F850", Length = "0x33")]
	[Token(Token = "0x60005FC")]
	private static int get_bottom_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3010530", Offset = "0x300F930", Length = "0x51")]
	[Token(Token = "0x60005F3")]
	public int get_horizontal() { }

	[Address(RVA = "0x30104F0", Offset = "0x300F8F0", Length = "0x33")]
	[Token(Token = "0x60005FE")]
	private static int get_horizontal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30105D0", Offset = "0x300F9D0", Length = "0x51")]
	[Token(Token = "0x60005EB")]
	public int get_left() { }

	[Address(RVA = "0x3010590", Offset = "0x300F990", Length = "0x33")]
	[Token(Token = "0x60005F6")]
	private static int get_left_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3010670", Offset = "0x300FA70", Length = "0x51")]
	[Token(Token = "0x60005ED")]
	public int get_right() { }

	[Address(RVA = "0x3010630", Offset = "0x300FA30", Length = "0x33")]
	[Token(Token = "0x60005F8")]
	private static int get_right_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3010710", Offset = "0x300FB10", Length = "0x51")]
	[Token(Token = "0x60005EF")]
	public int get_top() { }

	[Address(RVA = "0x30106D0", Offset = "0x300FAD0", Length = "0x33")]
	[Token(Token = "0x60005FA")]
	private static int get_top_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30107B0", Offset = "0x300FBB0", Length = "0x51")]
	[Token(Token = "0x60005F4")]
	public int get_vertical() { }

	[Address(RVA = "0x3010770", Offset = "0x300FB70", Length = "0x33")]
	[Token(Token = "0x60005FF")]
	private static int get_vertical_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x300FDB0", Offset = "0x300F1B0", Length = "0x2A")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60005E9")]
	private static IntPtr InternalCreate() { }

	[Address(RVA = "0x300FDE0", Offset = "0x300F1E0", Length = "0x33")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60005EA")]
	private static void InternalDestroy(IntPtr ptr) { }

	[Address(RVA = "0x300FE80", Offset = "0x300F280", Length = "0x78")]
	[Token(Token = "0x60005F5")]
	public Rect Remove(Rect rect) { }

	[Address(RVA = "0x300FE20", Offset = "0x300F220", Length = "0x52")]
	[Token(Token = "0x6000600")]
	private static void Remove_Injected(IntPtr _unity_self, in Rect rect, out Rect ret) { }

	[Address(RVA = "0x3010850", Offset = "0x300FC50", Length = "0x58")]
	[Token(Token = "0x60005F2")]
	public void set_bottom(int value) { }

	[Address(RVA = "0x3010810", Offset = "0x300FC10", Length = "0x40")]
	[Token(Token = "0x60005FD")]
	private static void set_bottom_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x30108F0", Offset = "0x300FCF0", Length = "0x58")]
	[Token(Token = "0x60005EC")]
	public void set_left(int value) { }

	[Address(RVA = "0x30108B0", Offset = "0x300FCB0", Length = "0x40")]
	[Token(Token = "0x60005F7")]
	private static void set_left_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3010990", Offset = "0x300FD90", Length = "0x58")]
	[Token(Token = "0x60005EE")]
	public void set_right(int value) { }

	[Address(RVA = "0x3010950", Offset = "0x300FD50", Length = "0x40")]
	[Token(Token = "0x60005F9")]
	private static void set_right_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3010A30", Offset = "0x300FE30", Length = "0x58")]
	[Token(Token = "0x60005F0")]
	public void set_top(int value) { }

	[Address(RVA = "0x30109F0", Offset = "0x300FDF0", Length = "0x40")]
	[Token(Token = "0x60005FB")]
	private static void set_top_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x300FF10", Offset = "0x300F310", Length = "0x349")]
	[Token(Token = "0x60005E7")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x300FF00", Offset = "0x300F300", Length = "0xF")]
	[Token(Token = "0x60005E6")]
	public virtual string ToString() { }

}

