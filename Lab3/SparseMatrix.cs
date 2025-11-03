public class SparseMatrix<T>
{
    private readonly Dictionary<int, Dictionary<int, Dictionary<int, T>>> _matrix = new();

    public T? this[int x, int y, int z]
    {
        get
        {
            if (_matrix.TryGetValue(x, out var plane) &&
                plane.TryGetValue(y, out var row) &&
                row.TryGetValue(z, out var value))
            {
                return value;
            }
            return default;
        }
        set
        {
            if (value != null)
            {
                if (!_matrix.ContainsKey(x)) _matrix[x] = new();
                if (!_matrix[x].ContainsKey(y)) _matrix[x][y] = new();
                _matrix[x][y][z] = value;
            }
            else
            {
                if (_matrix.TryGetValue(x, out var plane) &&
                    plane.TryGetValue(y, out var row))
                {
                    row.Remove(z);
                    if (row.Count == 0) plane.Remove(y);
                    if (plane.Count == 0) _matrix.Remove(x);
                }
            }
        }
    }

    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("\nСодержимое разреженной матрицы: ");
        
        if (_matrix.Count == 0)
        {
            return sb.AppendLine("Матрица пуста.").ToString();
        }

        foreach (var x in _matrix.Keys.OrderBy(k => k))
        {
            foreach (var y in _matrix[x].Keys.OrderBy(k => k))
            {
                foreach (var z in _matrix[x][y].Keys.OrderBy(k => k))
                {
                    sb.AppendLine($"[x:{x}, y:{y}, z:{z}] = {_matrix[x][y][z]}");
                }
            }
        }
        return sb.ToString();
    }
}
