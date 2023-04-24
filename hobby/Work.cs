// Для работы
int count=1;
while(count<2600)
{
Directory.CreateDirectory($"{count}");
count= count + 10;
}
