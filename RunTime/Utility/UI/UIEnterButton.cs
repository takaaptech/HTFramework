﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace HT.Framework
{
    /// <summary>
    /// UGUI靠近按钮
    /// </summary>
    [AddComponentMenu("HTFramework/UI/UIEnterButton")]
    [RequireComponent(typeof(Graphic))]
    [DisallowMultipleComponent]
    public sealed class UIEnterButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public UnityEvent OnEnter;
        public UnityEvent OnExit;

        public void OnPointerEnter(PointerEventData eventData)
        {
            OnEnter.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            OnExit.Invoke();
        }
    }
}
