try{
    // Create an instance of StreamReader to read from a file.
    // The using statement also closes the StreamReader.
    using (StreamReader sr = new StreamReader("e:/jollyjumpers.txt"))
    {
        string line;

        // Read and display lines from the file until 
        // the end of the file is reached. 
        while ((line = sr.ReadLine()) != null)
        {
            //Console.WriteLine(line);
            string[] words = line.Split(" ");
            int N = words.Length;
            int[] nums = Array.ConvertAll(words, int.Parse);
            Boolean isJolly = true;

            for (int i = 0; i < N - 1; i++)
            {
                if (Math.Abs(nums[i] - nums[i+1]) > N - 1) { 
                    
                    isJolly = false; 
                    break; 
                }
            }

            if (isJolly)
                Console.WriteLine("Jolly");
            else
                Console.WriteLine("Not Jolly");

        }
    }
}
catch (Exception e)
{
    // Let the user know what went wrong.
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}