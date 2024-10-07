using System;

public class Matrix
{
    private int[,] matrix;

    public int Rows { get; }
    public int Columns { get; }

    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        matrix = new int[rows, columns];
    }

    public int this[int row, int col]
    {
        get { return matrix[row, col]; }
        set { matrix[row, col] = value; }
    }

    public static Matrix operator +(Matrix mat1, Matrix mat2)
    {
        if (mat1.Rows != mat2.Rows || mat1.Columns != mat2.Columns)
            throw new InvalidOperationException("Матриці повинні мати однакові розміри!");

        Matrix result = new Matrix(mat1.Rows, mat1.Columns);
        for (int i = 0; i < mat1.Rows; i++)
        {
            for (int j = 0; j < mat1.Columns; j++)
            {
                result[i, j] = mat1[i, j] + mat2[i, j];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix mat1, Matrix mat2)
    {
        if (mat1.Rows != mat2.Rows || mat1.Columns != mat2.Columns)
            throw new InvalidOperationException("Матриці повинні мати однакові розміри!");

        Matrix result = new Matrix(mat1.Rows, mat1.Columns);
        for (int i = 0; i < mat1.Rows; i++)
        {
            for (int j = 0; j < mat1.Columns; j++)
            {
                result[i, j] = mat1[i, j] - mat2[i, j];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix mat1, Matrix mat2)
    {
        if (mat1.Columns != mat2.Rows)
            throw new InvalidOperationException("Кількість стовпців першої матриці повинна дорівнювати кількості рядків другої!");

        Matrix result = new Matrix(mat1.Rows, mat2.Columns);
        for (int i = 0; i < result.Rows; i++)
        {
            for (int j = 0; j < result.Columns; j++)
            {
                for (int k = 0; k < mat1.Columns; k++)
                {
                    result[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix mat, int scalar)
    {
        Matrix result = new Matrix(mat.Rows, mat.Columns);
        for (int i = 0; i < mat.Rows; i++)
        {
            for (int j = 0; j < mat.Columns; j++)
            {
                result[i, j] = mat[i, j] * scalar;
            }
        }
        return result;
    }

    public static bool operator ==(Matrix mat1, Matrix mat2)
    {
        if (mat1.Rows != mat2.Rows || mat1.Columns != mat2.Columns)
            return false;

        for (int i = 0; i < mat1.Rows; i++)
        {
            for (int j = 0; j < mat1.Columns; j++)
            {
                if (mat1[i, j] != mat2[i, j])
                    return false;
            }
        }
        return true;
    }

    public static bool operator !=(Matrix mat1, Matrix mat2)
    {
        return !(mat1 == mat2);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Matrix))
        {
            return false;
        }
        Matrix mat = obj as Matrix;
        return this == mat;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        foreach (int element in matrix)
        {
            hash = hash * 31 + element;
        }
        return hash;
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Matrix mat1 = new Matrix(2, 2);
        mat1[0, 0] = 1; mat1[0, 1] = 2;
        mat1[1, 0] = 3; mat1[1, 1] = 4;

        Matrix mat2 = new Matrix(2, 2);
        mat2[0, 0] = 5; mat2[0, 1] = 6;
        mat2[1, 0] = 7; mat2[1, 1] = 8;

        Matrix resultAdd = mat1 + mat2;
        Matrix resultSub = mat1 - mat2;
        Matrix resultMul = mat1 * mat2;
        Matrix resultScalarMul = mat1 * 2;

        Console.WriteLine($"Матриця після додавання: [{resultAdd[0, 0]}, {resultAdd[0, 1]}, {resultAdd[1, 0]}, {resultAdd[1, 1]}]");
        Console.WriteLine($"Матриця після віднімання: [{resultSub[0, 0]}, {resultSub[0, 1]}, {resultSub[1, 0]}, {resultSub[1, 1]}]");
        Console.WriteLine($"Матриця після множення: [{resultMul[0, 0]}, {resultMul[0, 1]}, {resultMul[1, 0]}, {resultMul[1, 1]}]");
        Console.WriteLine($"Матриця після множення на число: [{resultScalarMul[0, 0]}, {resultScalarMul[0, 1]}, {resultScalarMul[1, 0]}, {resultScalarMul[1, 1]}]");
    }
}
