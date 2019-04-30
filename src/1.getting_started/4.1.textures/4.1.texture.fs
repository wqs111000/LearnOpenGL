#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;

void main()
{
//ʹ��GLSL�ڽ���texture�����������������ɫ������һ��������������������ڶ��������Ƕ�Ӧ���������ꡣ
	FragColor = texture(texture1, TexCoord);
}