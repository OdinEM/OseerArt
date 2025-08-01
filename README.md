Oseer Art Therapy – AR Sketch Visualizer

An Augmented Reality (AR) drawing assistant designed for the deaf and hard-of-hearing community, allowing users to trace and sketch images on paper using their smartphone camera. Inspired by the Da Vinci Eye app, this project integrates Vuforia AR and Unity to make art education and therapy more accessible.

Project Overview

Oseer Art Therapy overlays reference images on a real-world sheet of paper through your phone’s camera, enabling users to trace directly on the paper.

Key goals:

Promote inclusive vocational and art education for the deaf community
Provide a visual-first AR sketching experience without audio instructions
Support custom gallery image imports for flexible drawing exercises

Core Features

AR Image Tracking
Uses a printed logo as the AR anchor
Real-time stable image overlay for accurate tracing
Auto re-tracking if the camera loses the marker

Template Switching
Cycle through multiple built-in sketch templates
Adjust scale and opacity for clear tracing
Next / Previous controls for user-friendly navigation

Gallery Image Import
Import custom images directly from the device gallery
Instantly use them as sketch overlays

Accessibility Design
Visual-first UI – no audio instructions required
Large buttons and high-contrast icons for clarity
Supports portrait and landscape modes

Technology Stack

Unity 6 – Core development platform
Vuforia Engine – AR image recognition & tracking
C# – Game logic and UI scripting
Native Gallery Plugin – For importing user images
Android (7.0+) – Target platform 

How to Use

Launch the app – The camera view opens
Place the printed logo marker on your paper
Align the camera until the AR overlay appears
Select a sketch template or import from gallery
Adjust scale & opacity to your preference
Trace the overlay directly onto your paper

Performance Considerations

Average test performance: ~14.8 FPS on mid-range devices
AR performance is affected by tracking and high-res textures

Optimizations planned:
Reduce texture resolution to 1024px or lower
Use unlit shaders for overlays
Limit active AR elements to improve FPS
