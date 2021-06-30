# Stride3dSplitScreen

This is an example project on how to setup a split screen in Stride3d.

Note that most of the configuration is done in the Graphics compositor. See the documentation here: https://doc.stride3d.net/4.0/en/Manual/graphics/graphics-compositor/index.html

Some minutiae to note:
* The render masks of each camera is set - Main camera only has render group 31. Player1/2 have every render group *except* 31.
* The main camera does not have post processing turned on for it. Only the player cameras have it enabled.
* Main camera is Orthographic. It only purpose is to render the HUD UI element, which has the camera layout.
