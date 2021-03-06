//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

new Material(w_swarmgun)
{
   mapTo = "w_swarmgun";
   diffuseMap[0] = "w_swarmgun";
   normalMap[0] = "w_swarmgun_bump";
   pixelSpecular[0] = true;
   specular[0] = "1.0 1.0 1.0 1.0";
   specularPower[0] = 32.0;
   materialTag0 = "Weapon";
};

new Material(guide)
{
   mapTo = "guide";
   diffuseMap[0] = "guide";
   emissive[0] = true;
   glow[0] = true;
   materialTag0 = "Weapon";
   materialTag1 = "FX";
};

new Material(energy)
{
   mapTo = "energy";
   diffuseMap[0] = "energy.png";
   emissive[0] = true;
   glow[0] = true;
   materialTag0 = "Weapon";
   materialTag1 = "FX";
};
