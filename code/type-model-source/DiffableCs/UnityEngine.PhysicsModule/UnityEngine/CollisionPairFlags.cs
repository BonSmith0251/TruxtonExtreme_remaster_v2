namespace UnityEngine;

[Token(Token = "0x2000018")]
internal enum CollisionPairFlags : ushort
{
	RemovedShape = 1,
	RemovedOtherShape = 2,
	ActorPairHasFirstTouch = 4,
	ActorPairLostTouch = 8,
	InternalHasImpulses = 16,
	InternalContactsAreFlipped = 32,
}

