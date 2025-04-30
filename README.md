# 🎬 AnimEvent Editor

**AnimEvent Editor** is a lightweight, powerful Unity Editor extension that lets you preview animations and insert Animation Events with precision — directly from a custom editor window.  
Whether you're syncing **footsteps**, **VFX**, **sword slashes**, or **sound effects**, this tool makes event placement fast and intuitive.

---

## ✨ Features

- 🎞️ Preview any `AnimationClip` on a character inside the scene.
- 🎚️ Scrub the timeline manually with a time slider.
- ⚡ Instantly add **Animation Events** at any frame.
- ✍️ Assign event function names and optional object parameters.
- 🔁 Real-time update of clips for gameplay use.

---

## 🚀 Getting Started

1. In Unity, open the editor from `TalaeiDev > AnimEvent Editor`.
2. Assign a **Character** (scene object with an `Animator` component).
3. Select an **Animation Clip**.
4. Use the **slider** to scrub through the clip and preview motion.
5. Set a **Function Name** and optional **Object Parameter**.
6. Click **"Add Event at Current Time"** to inject an `AnimationEvent`.

> ✅ Works best with scene-instantiated characters, not prefab assets directly.

---

## 📦 Requirements

- Unity **2022 LTS** or **Unity 6.0+** (2024 LTS) recommended.
- Character object must be active in the scene with an `Animator` component.

---

## 🛠️ Planned Features

- 🔉 **Play Sound or VFX During Preview**  
  - Preview **slash**, **impact**, or **footstep** effects right in the editor.  
  - Supports `AudioClip`, `ParticleSystem`, or prefab-based triggers.

- 🪟 **Separate Animation Preview Window**  
  - Preview your animation in a **dedicated, minimal UI panel**, independent of the Scene view.

- 🎚️ **Animation Curve Editing**  
  - Add and manage custom animation curves (e.g., for float parameters, shader intensities, etc.).  
  - Curve editor embedded directly in the event tool.

- 🦶 **Auto Footstep Detection**  
  - Automatically place footstep events based on foot bone height or ground contact timing.

- 🗂️ **Event Categories & Color Labels**  
  - Organize events with visual tags (e.g., `Footstep`, `Attack`, `Effect`) in the timeline.

- 🔁 **Batch Event Editing**  
  - Copy/paste events across clips or rigs.  
  - Export/import events as JSON or ScriptableObject.

---

## 🧠 Why Use This Tool?

Unity’s built-in Animation Event editor is functional but limited.  
**AnimEvent Editor** gives you:
- Real-time, scrub-based feedback
- More precise control over timing
- Fast workflows for VFX/audio syncing
- A better foundation for scaling to multi-clip workflows

---

## 💬 Support & Feedback

Have questions or want to suggest features?  
Feel free to [open an issue](https://github.com/YOUR-USERNAME/YOUR-REPO/issues) or start a discussion!

---

## 📄 License

MIT License  
Free to use, modify, and distribute — with attribution.

---

> Made with ❤️ by **TalaeiDev**
