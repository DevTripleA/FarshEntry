SELECT p.Word, d.Difference FROM Differences AS d JOIN Positions AS p ON d.PositionId = p.Id WHERE d.Id = {0}
