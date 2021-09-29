using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScene : MonoBehaviour
{
    [SerializeField]
    public Material cubeMaterial;

    public int spinSpeed;
    public Vector3 RotateAmount;
    public Texture myTexture;

    float width = 10.0f;
    float height = 10.0f;
    float thick = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = 4;
        RotateAmount = new Vector3(0.0f, 50.0f, 0.0f);
        Mesh mesh = new Mesh();
        var vertices = new Vector3[30];
        var uvs = new Vector2[vertices.Length];

        myTexture = Resources.Load<Texture>("Textures/ruangan");
        cubeMaterial.mainTexture = myTexture;

        vertices[0] = new Vector3(width, height, thick);
        vertices[1] = new Vector3(width, -height, thick);
        vertices[2] = new Vector3(width, height, -thick);
        vertices[3] = new Vector3(width, -height, -thick);

        vertices[4] = new Vector3(width, height, thick);
        vertices[5] = new Vector3(-width, height, thick);
        vertices[6] = new Vector3(width, height, -thick);
        vertices[7] = new Vector3(-width, height, -thick);

        vertices[8] = new Vector3(width, height, thick);
        vertices[9] = new Vector3(-width, height, thick);
        vertices[10] = new Vector3(width, -height, thick);
        vertices[11] = new Vector3(-width, -height, thick);

        vertices[12] = new Vector3(-width, height, thick);
        vertices[13] = new Vector3(-width, -height, thick);
        vertices[14] = new Vector3(-width, height, -thick);
        vertices[15] = new Vector3(-width, -height, -thick);

        vertices[16] = new Vector3(width, -height, thick);
        vertices[17] = new Vector3(-width, -height, thick);
        vertices[18] = new Vector3(width, -height, -thick);
        vertices[19] = new Vector3(-width, -height, -thick);

        vertices[20] = new Vector3(width, height, -thick);
        vertices[21] = new Vector3(-width, height, -thick);
        vertices[22] = new Vector3(width, -height, -thick);
        vertices[23] = new Vector3(-width, -height, -thick);

        uvs[0] = new Vector2(0.25f, 2.0f / 3.0f);
        uvs[1] = new Vector2(0.25f, 1.0f / 3.0f);
        uvs[2] = new Vector2(0.0f, 2.0f / 3.0f);
        uvs[3] = new Vector2(0.0f, 1.0f / 3.0f);

        uvs[4] = new Vector2(0.75f, 1f);
        uvs[5] = new Vector2(0.5f, 1f);
        uvs[6] = new Vector2(0.75f, 2.0f / 3.0f);
        uvs[7] = new Vector2(0.5f, 2.0f / 3.0f);

        uvs[8] = new Vector2(0.25f, 2.0f / 3.0f);
        uvs[9] = new Vector2(0.5f, 2.0f / 3.0f);
        uvs[10] = new Vector2(0.25f, 1.0f / 3.0f);
        uvs[11] = new Vector2(0.5f, 1.0f / 3.0f);

        uvs[12] = new Vector2(0.5f, 2.0f / 3.0f);
        uvs[13] = new Vector2(0.5f, 1.0f / 3.0f);
        uvs[14] = new Vector2(0.75f, 2.0f / 3.0f);
        uvs[15] = new Vector2(0.75f, 1.0f / 3.0f);

        uvs[16] = new Vector2(0.5f, 0.0f);
        uvs[17] = new Vector2(0.5f, 1.0f / 3.0f);
        uvs[18] = new Vector2(0.75f, 0.0f);
        uvs[19] = new Vector2(0.75f, 1.0f / 3.0f);

        uvs[20] = new Vector2(1.0f, 2.0f / 3.0f);
        uvs[21] = new Vector2(0.75f, 2.0f / 3.0f);
        uvs[22] = new Vector2(1.0f, 1.0f / 3.0f);
        uvs[23] = new Vector2(0.75f, 1.0f / 3.0f);

        mesh.vertices = vertices;

        var colors = new Color32[vertices.Length];
        colors[0] = new Color32(169, 169, 169, 255);
        colors[1] = new Color32(169, 169, 169, 255);
        colors[2] = new Color32(169, 169, 169, 255);
        colors[3] = new Color32(169, 169, 169, 255);

        colors[4] = new Color32(169, 169, 169, 255);
        colors[5] = new Color32(169, 169, 169, 255);
        colors[6] = new Color32(169, 169, 169, 255);
        colors[7] = new Color32(169, 169, 169, 255);

        colors[8] = new Color32(169, 169, 169, 255);
        colors[9] = new Color32(169, 169, 169, 255);
        colors[10] = new Color32(169, 169, 169, 255);
        colors[11] = new Color32(169, 169, 169, 255);

        colors[12] = new Color32(169, 169, 169, 255);
        colors[13] = new Color32(169, 169, 169, 255);
        colors[14] = new Color32(169, 169, 169, 255);
        colors[15] = new Color32(169, 169, 169, 255);

        colors[16] = new Color32(169, 169, 169, 255);
        colors[17] = new Color32(169, 169, 169, 255);
        colors[18] = new Color32(169, 169, 169, 255);
        colors[19] = new Color32(169, 169, 169, 255);

        colors[20] = new Color32(169, 169, 169, 255);
        colors[21] = new Color32(169, 169, 169, 255);
        colors[22] = new Color32(169, 169, 169, 255);
        colors[23] = new Color32(169, 169, 169, 255);

        mesh.colors32 = colors;

        mesh.uv = uvs;

        mesh.triangles = new int[]
        {
            1,0,2,
            3,1,2,
            5,7,6,
            5,6,4,
            11,9,8,
            10,11,8,
            13,14,12,
            13,15,14,
            17,18,19,
            17,16,18,
            23,20,21,
            23,22,20
        };

        mesh.normals = new Vector3[]
        {
            new Vector3(1.0f,0.0f,0.0f),
            new Vector3(1.0f,0.0f,0.0f),
            new Vector3(1.0f,0.0f,0.0f),
            new Vector3(1.0f,0.0f,0.0f),

            new Vector3(0.0f,1.0f,0.0f),
            new Vector3(0.0f,1.0f,0.0f),
            new Vector3(0.0f,1.0f,0.0f),
            new Vector3(0.0f,1.0f,0.0f),

            new Vector3(0.0f,0.0f,1.0f),
            new Vector3(0.0f,0.0f,1.0f),
            new Vector3(0.0f,0.0f,1.0f),
            new Vector3(0.0f,0.0f,1.0f),

            new Vector3(-1.0f,0.0f,0.0f),
            new Vector3(-1.0f,0.0f,0.0f),
            new Vector3(-1.0f,0.0f,0.0f),
            new Vector3(-1.0f,0.0f,0.0f),

            new Vector3(0.0f,-1.0f,0.0f),
            new Vector3(0.0f,-1.0f,0.0f),
            new Vector3(0.0f,-1.0f,0.0f),
            new Vector3(0.0f,-1.0f,0.0f),

            new Vector3(0.0f,0.0f,-1.0f),
            new Vector3(0.0f,0.0f,-1.0f),
            new Vector3(0.0f,0.0f,-1.0f),
            new Vector3(0.0f,0.0f,-1.0f),
        };
        mesh.RecalculateNormals();
        GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshRenderer>().material = cubeMaterial;

        foreach (Vector3 normal in GetComponent<MeshFilter>().mesh.normals)
        {
            Debug.Log(normal.x + " " + normal.y + " " + normal.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myTexture.filterMode = SwitchFilterModes();
            Debug.Log("Filter mode : " + myTexture.filterMode);
        }
    }

    FilterMode SwitchFilterModes()
    {
        switch (myTexture.filterMode)
        {
            case FilterMode.Bilinear:
                myTexture.filterMode = FilterMode.Point;
                break;
            case FilterMode.Point:
                myTexture.filterMode = FilterMode.Trilinear;
                break;
            case FilterMode.Trilinear:
                myTexture.filterMode = FilterMode.Bilinear;
                break;
        }
        return myTexture.filterMode;
    }
}
