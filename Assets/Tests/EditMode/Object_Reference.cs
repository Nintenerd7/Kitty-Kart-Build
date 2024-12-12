using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class Object_Reference : MonoBehaviour
{

    [UnityTest]
    public IEnumerator Object_ReferenceWithEnumeratorPasses()
    {
        var points = new Object_Calc();
        var expectedpoints = 3*100*1;
        // Use yield to skip a frame.

        var calc = points.CalculatePoints(3,0,1);
        Assert.That(calc, Is.EqualTo(expectedpoints));
        yield return null;
    }

}
