﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Adnc.SkillTree {
	abstract public class SkillCollectionBase : MonoBehaviour {
		public string displayName = "Skill Collection";
		public string uniqueName;

		// Determines what skill is currently active and returns it
		int skillIndex = 0;
		public int SkillIndex {
			get {
				return skillIndex;
			}

			set {
				if (value >= 0 && value < transform.childCount) {
					skillIndex = value;
				} 
			}
		}

		public SkillBase Skill {
			get {
				return transform.GetChild(skillIndex).GetComponent<SkillBase>();
			}
		}

		[TextArea(3, 5)]
		public string description;

		[Header("Window Debug Data")]
		public Rect windowRect;
		[HideInInspector] public List<SkillCollectionBase> childSkills = new List<SkillCollectionBase>();
	}
}