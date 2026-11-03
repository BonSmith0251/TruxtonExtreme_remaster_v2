namespace UnityEngine;

[Token(Token = "0x2000184")]
internal class AttributeHelperEngine
{
	[Token(Token = "0x4000621")]
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; //Field offset: 0x0
	[Token(Token = "0x4000622")]
	public static ExecuteInEditMode[] _executeInEditModeArray; //Field offset: 0x8
	[Token(Token = "0x4000623")]
	public static RequireComponent[] _requireComponentArray; //Field offset: 0x10

	[Address(RVA = "0x30559C0", Offset = "0x3054DC0", Length = "0xFA")]
	[Token(Token = "0x600127F")]
	private static AttributeHelperEngine() { }

	[Address(RVA = "0x30550D0", Offset = "0x30544D0", Length = "0x1DC")]
	[RequiredByNativeCode]
	[Token(Token = "0x600127C")]
	private static int CheckIsEditorScript(Type klass) { }

	[Address(RVA = "0x746080", Offset = "0x745480", Length = "0xD1")]
	[Token(Token = "0x600127E")]
	private static T GetCustomAttributeOfType(Type klass) { }

	[Address(RVA = "0x30552B0", Offset = "0x30546B0", Length = "0x69")]
	[RequiredByNativeCode]
	[Token(Token = "0x600127D")]
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	[Address(RVA = "0x3055320", Offset = "0x3054720", Length = "0xFF")]
	[Token(Token = "0x600127B")]
	private static int GetExecuteMode(Type klass) { }

	[Address(RVA = "0x3055420", Offset = "0x3054820", Length = "0x127")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001279")]
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[Address(RVA = "0x3055550", Offset = "0x3054950", Length = "0x463")]
	[RequiredByNativeCode]
	[Token(Token = "0x600127A")]
	private static Type[] GetRequiredComponents(Type klass) { }

}

