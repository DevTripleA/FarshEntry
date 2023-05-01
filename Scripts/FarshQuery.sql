SELECT 
	d.Id AS DifferenceId, 
	p.Word AS PositionWord, 
	d.Difference AS Difference, 
	(SELECT STRING_AGG (r.Name, '، ') FROM Readers AS r WHERE Exists(SELECT 1 FROM Ways AS w WHERE DifferenceId = d.Id AND w.ReaderId = r.Id)) AS ReadersNames,
	c.Name AS ChapterName,
	p.Verse AS Verse,
	p.Page AS Page
FROM Differences AS d
JOIN Positions AS p ON d.PositionId = p.Id
JOIN Chapters AS c ON p.ChapterId = c.Id
ORDER BY d.Id
