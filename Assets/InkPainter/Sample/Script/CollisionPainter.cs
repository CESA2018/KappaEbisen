using UnityEngine;

namespace Es.InkPainter.Sample
{
	[RequireComponent(typeof(Collider), typeof(MeshRenderer))]
	public class CollisionPainter : MonoBehaviour
	{


		[SerializeField]
		private Brush brush = null;

		[SerializeField]
		private int wait = 3;

		private int waitCount;

		public void Awake()
		{
			GetComponent<MeshRenderer>().material.color = brush.Color;
		}

		public void FixedUpdate()
		{
			++waitCount;
		}

		public void OnCollisionEnter(Collision collision)
		{
			if(waitCount < wait)
				return;
			waitCount = 0;

			foreach(var p in collision.contacts)
			{
				var canvas = p.otherCollider.GetComponent<InkCanvas>();
				if(canvas != null)
					canvas.Paint(brush, p.point);
			}
            //Vector3 hitPos;
            //foreach (ContactPoint point in collision.contacts)
            //{
            //    hitPos = point.point;

            //    switch(collision.gameObject.name)
            //    {
            //        case "SphereFirst":
            //            Instantiate(ClearCanvas, transform);
            //            Debug.Log("FirstHit");
            //            break;
            //        case "SphereSecond":
            //            break;
            //        case "SphereThird":
            //            break;
            //        case "SphereFourth":
            //            break;
            //        case "SphereFifth":
            //            break;
            //    }


            //    //Debug.Log(hitPos);
            //}

            gameObject.SetActive(false);
		}
    }
}