public class Rectangle{
    private int _width;
    private int _height;

    public Rectangle(int width,int height)
    {
        _width=width;
        _height=height;
        
    }
    public int GetArea(){
        return _width*_height;
    }
}