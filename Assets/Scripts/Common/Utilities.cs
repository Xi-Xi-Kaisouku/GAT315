using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static Vector2 Wrap(Vector2 point, Vector2 min, Vector2 max)
    {
        if (point.x > max.x) point.x = min.x;

        return point;
    }

	public static Vector2 SpringForce(Vector2 source, Vector2 destination, float restLength, float k)
	{
		Vector2 direction = destination - source;
		float length = direction.magnitude;
		float x = length - restLength;

		Vector2 force = (-k * x) * direction.normalized;

		return force;
	}
}
