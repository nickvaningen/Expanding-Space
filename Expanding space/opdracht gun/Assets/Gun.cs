using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	
	public class Gun:MonoBehaviour
    {
    public int magsize;
    public int _bulletsinclip;
    public virtual void Shoot()
        {
        if (_bulletsinclip > 0)
        {
            Debug.Log("shoooeet the cannon");
            _bulletsinclip--;
        }
        else
        {
            Debug.Log("we need to reload");
        }
    }
        public void Reload()
        {
        _bulletsinclip = magsize;
        Debug.Log("reload the cannon");
        }
    }
    
