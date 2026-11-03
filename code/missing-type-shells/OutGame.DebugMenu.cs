// Field-preserving layout shells reconstructed from original type trees. No recovered behavior.
// Base MonoBehaviour is a flattened serialization approximation, not recovered inheritance.
using System;
using UnityEngine;
using KANAI.Popup;
using KANAI.UI;
namespace OutGame.DebugMenu {
 [Serializable] public class ComboButtonSelecter { public GameObject groupPrehub; public PopupButton button; public UISlideSelecter selecter; }
 [Serializable] public class ComboButtonSelecterP { public GameObject groupPrehub; public PopupButton button; public UISlideSelecter selecter; public UITextMeshPro arms; public UITextMeshPro pow; public UITextMeshPro speed; }
 public class DebugStoryPresenter : MonoBehaviour { public ComboButtonSelecterP[] _items; public GameObject[] _itemGroups; }
 public class DebugServiceRecordPresenter : MonoBehaviour { public ComboButtonSelecter[] _items; public UITextMeshPro _playerLevel; }
 public class DebugArcadeTeamPresenter : MonoBehaviour { public ComboButtonSelecter[] _items; }
 public class DebugTrophyPresenter : MonoBehaviour { public ComboButtonSelecter[] _items; }
 public class DebugEtcPresenter : MonoBehaviour { public ComboButtonSelecter[] _items; }
 public class DebugMenuPresenter : MonoBehaviour { public ComboButtonSelecter[] _items; }
 public class DebugStoryArmsSelectPopupContent : MonoBehaviour {
  public bool _useInspectorParam; public Vector2 _popupSize; public Vector2 _displayOffset;
  public PopupButton[] _buttons; public OutGame.UI.TXERSelecter _arms;
  public OutGame.UI.TXERSelecterNumber _power; public OutGame.UI.TXERSelecterNumber _speed;
 }
}
