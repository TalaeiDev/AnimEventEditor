# AnimEvent Editor

A lightweight Unity Editor tool for **previewing animations** and **adding Animation Events** easily inside the Unity Editor.

---

## ✨ Features
- 🎞️ Preview any `AnimationClip` on a character in the scene.
- 🎚️ Control animation playback manually with a time slider.
- ⚡ Quickly add **Animation Events** at any point.
- 🛠️ Set **function names** and **optional object parameters**.
- 🔄 Instantly updates your clips for use in gameplay or effects (e.g., footsteps, sword slashes).

---

## 🚀 Getting Started

1. Open Unity and navigate to `TalaeiDev > AnimEvent Editor`.
2. Drag and drop a **Character** (scene object with an `Animator` component) into the Character field.
3. Select an **Animation Clip** you want to preview.
4. Use the **time slider** to scrub through the animation.
5. Set the **Event Function Name**.
6. (Optional) Assign an **Object Parameter** if needed.
7. Click **"Add Event at Current Time"** to insert an `AnimationEvent` into the clip!

---

## 📦 Requirements
- Unity **2022 LTS** or later recommended.
- Full support for **Unity 6** (2024+) versions.
- A **Character GameObject** in the scene (must have an `Animator` component).

---

## 📋 Notes
- Make sure your Character is **instantiated in the scene**, not just a prefab from the Project window.
- Works with **generic**, **humanoid**, and **legacy** animations.
- This tool modifies the selected AnimationClip by adding events.

---

🛠 Future Plans
🔉 Play Sound or VFX During Preview
Automatically trigger and preview footsteps, slash effects, or hit sounds based on animation events.

Support for AudioClip, ParticleSystem, or prefab-based VFX.

Preview effects directly in the Editor as you scrub.

🪟 Separate Animation Preview Window
Add a dedicated preview window that renders the animated character in a clean, focused UI, separate from the Scene view.

🎚️ Animation Curve Editing Support
Add and edit custom animation curves (e.g., for blending, float properties, shader effects, or motion parameters).

Integrated curve field for easy editing.

Support for curve-driven event triggers.

🦶 Auto Footstep Detection
Detect foot contact automatically using foot position or root motion and place footstep events for you.

🗂️ Event Categories with Color Labels
Visually group events (e.g., Footstep, Slash, Impact) on the timeline using color-coded markers for better readability.

🔁 Batch Event Editing
Copy/paste events between clips.

Apply events to multiple clips or character rigs.

Export/import to JSON or ScriptableObjects.

---

## 💬 Support
If you encounter any issues or have suggestions for new features, feel free to open an issue or start a discussion!

---

> Made with ❤️ by TalaeiDev
