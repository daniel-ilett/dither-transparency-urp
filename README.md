# Dither Transparency in Unity URP

A dither transparency shader for Unity's Shader Graph and Universal Render Pipeline.

![Dither Banner](banner.jpg)

## Overview

This project features an efficient dither tarnsparency shader which uses a world-space Bayer dither matrix to cull object pixels to 'fake' a transparency-like effect without the need to implement actual transparency. It uses the features of Shader Graph and Universal RP. An accompanying tutorial is available on [danielilett.com](https://danielilett.com/2020-04-19-tut5-5-urp-dither-transparency/).

## Usage and Demo

The project contains two custom shaders that can be used for your materials.

- DitherTransparent: Shadows cast by the object also have the dithering pattern.
- DitherTransparentOriginalShadow: The original opaque shadow is cast no matter the opacity. The shader has an additional node to set IsShadowCaster to true.

The shaders have a Vector1 called "Opacity" to control how opaque the object is—the higher it is, the less the object will be dithered.
You can adjust the opacity via script like so:

    float newOpacityValue = 0.5;
    renderer.material.SetFloat("_Opacity", newOpacityValue);

If you run the SampleScene contained in the project, you will see the robotSphere fading in and out with the dither pattern. This is being done by the FadeInOut class found in the Scripts folder.


## Software

This project was created using Unity 2019.3.0f6 and Universal Render Pipeline 7.1.8.

## Authors

This project and the corresponding tutorial series were written by Daniel Ilett. [Follow him on Twitter](https://twitter.com/daniel_ilett) for more gamedev tutorials!

## Release

This project was released on April 19th 2020. 
