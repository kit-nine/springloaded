using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Parallax : MonoBehaviour
{
private float lengthOfSprite,startPositionOfSprite;
    public float amountOfParallaxEffect;
public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
      startPositionOfSprite = transform.position.x;
      lengthOfSprite = GetComponent<SpriteRenderer>().bounds.size.x;
    }
// Update is called once per frame
    void FixedUpdate()
    {
      float distanceMoved = Camera.transform.position.x*amountOfParallaxEffect;
      float cameraBounds = Camera.transform.position.x*(1-amountOfParallaxEffect);
      transform.position = new Vector3(startPositionOfSprite+distanceMoved , transform.position.y , transform.position.z );
if(cameraBounds>startPositionOfSprite+lengthOfSprite) startPositionOfSprite += lengthOfSprite;
      else if(cameraBounds<startPositionOfSprite-lengthOfSprite) startPositionOfSprite -= lengthOfSprite;
    }
}