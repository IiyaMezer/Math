namespace Math;

public struct Matrix
{
    private int _Row; //Строки
    private int _Col; //Столбцы
    private readonly double[,] _M;
    
    public int Row
    {
        get => _Row;
        set => _Row = value;
    }

    public int Col
    {
        get => _Col;
        set => _Col = value;
    }

    public Matrix(int Row, int Col)
    {
        this._Row = Row;
        this._Col = Col;
        _M = new double[Row,Col];
    }

 ///ToDo
    public static Matrix operator +(Matrix M1, Matrix M2)
    {
        if (M1.Row != M2.Row || M1.Col != M2.Col)
        {
            throw new Exception($"Нельзя вычислить сумму, так как размерность матриц не совпадает:\n" +
                               $"M1: {M1.Col}x{M1.Row}\nM2: {M2.Col}x{M2.Row}");
        }
        
        
        ///ToDo сделать вычисление размерности новой матрицы, и ее создание с полученной размерностью ЗАДАТЬ В СИГНАТУРЕ КОНСТРУКТОРА. 
        ///делать это в перегрузке каждого операитора.
        var result = new Matrix();
        for (int i = 0; i < M1.Row; i++)
        {
            for (int j = 0; j < M1.Col; j++)
            {
                result[i,j] = M1[i, j] + M2[i,j];
            }
        }
        return result;
    }
    
    ///ToDo
     public static Matrix operator -(Matrix M1, Matrix M2)
    {
        return result;
    }
    
        ///ToDo
     public static Matrix operator *(Matrix M1, Matrix M2)
    {
        return result;
    }
    
            ///ToDo умножение матрицы на число
         public static Matrix operator *(Matrix M1, double a)
    {
        return result;
    }
            ///ToDo транспонирование матрицы
            ///ToDo вычисление диагонали
            ///ToDo детерминант
            ///ToDo определние ранга матрицы
            ///ToDo сравнения матриц ???
    

}



