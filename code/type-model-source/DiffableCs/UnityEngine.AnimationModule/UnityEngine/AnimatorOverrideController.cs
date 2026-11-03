namespace UnityEngine;

[DefaultMember("Item")]
[HelpURL("AnimatorOverrideController")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[Token(Token = "0x200001B")]
[UsedByNativeCode]
public class AnimatorOverrideController : RuntimeAnimatorController
{
	[Token(Token = "0x200001C")]
	public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000208")]
		public OnOverrideControllerDirtyCallback(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000209")]
		public override void Invoke() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000064")]
	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; //Field offset: 0x18

	[Address(RVA = "0x2FB4C50", Offset = "0x2FB4050", Length = "0x31")]
	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000207")]
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

