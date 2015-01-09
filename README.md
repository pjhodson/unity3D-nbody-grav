N-Body Gravitational Simulator 
==================

Basic N-Body Gravitational Simulation in Unity

A few notes - 

Any game object with the tag "gravBody" will be considered in calculations (in the Gravity script).

If you want to have an object stationary, put it in the scene, add a rigidbody, and tag it with "gravBody" - adjust its mass to fit your needs.

If you want to start an object moving at the beginning of the simulation, add the Initial Force script to an object. Give it a direction vector and a velocity. 

The Universal Constant of Gravitation is not used.

Forces are rounded.

Rigidbodies are used for application of forces and mass.


It's far from perfect.


Check it out here: http://pjhodson.com/nbody/web.html
