//Phan 1: Lam Quen

// Nhập và Xuất: Viết chương trình cho phép người dùng nhập vào $n$ phần tử số nguyên.
// In mảng đó ra màn hình theo chiều xuôi và chiều ngược lại.

// int[] arr = {1,2,3,4,5,6,7,8,9,0};
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.WriteLine(arr[i]);
// }
//
// Console.WriteLine("in nguoc lai");
// for (int i = arr.Length-1; i >= 0 ; i--)
// {
//     Console.WriteLine(arr[i]);
// }

//Tính toán: Tính tổng và trung bình cộng của tất cả các phần tử trong mảng.

// int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// int tong = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//         tong+= arr[i];
// }
//
// float TBC= (tong / arr.Length-1);
// Console.WriteLine(TBC);

//Tìm kiếm: Tìm giá trị lớn nhất (Max) và giá trị nhỏ nhất (Min) trong mảng.

// int[] arr = { 12, 2,33, 4,23,44, 5, 6, 7, 8, 9 };
// int max = arr[0];
// int min = arr[0];
// for (int i = 0; i < arr.Length; i++)
// {
//     if (max < arr[i])
//     {
//         max = arr[i];
//     }
// }
// Console.WriteLine($"So lon nhat trong mang la: "+max);
// for (int i = 0; i < arr.Length; i++)
// {
//     if  (min > arr[i])
//     {
//         min = arr[i];
//     }
// }
// Console.WriteLine($"So nho trong mang la: "+min);

//Phần 2: Xử lý logic (Trung cấp)
//Đếm phần tử: Đếm xem trong mảng có bao nhiêu số chẵn, bao nhiêu số lẻ và bao nhiêu số nguyên tố.

// int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12};
// int soChan =0;
// int soLe = 0;
// int soNguyenTo= 0;
//
// foreach (int num in arr)
// {
//     if (num % 2 == 0)
//     {
//         soChan++;
//     }
//     else
//     {
//         soLe++;
//     }
//
//     if (num >=2)
//     {
//         bool daylaSoNguyenTo = true;
//         for (int j = 2; j <= Math.Sqrt(num); j++)
//         {
//             if (num % 2 == 0)
//             {
//                 daylaSoNguyenTo = false;
//                 break;
//             }
//         }
//         if (daylaSoNguyenTo) soNguyenTo++;
//     }
// }
// Console.WriteLine($"So chan: {soChan}, So le: {soLe}, So nguyen to: {soNguyenTo}");

//Sắp xếp: Thực hiện sắp xếp mảng theo thứ tự tăng dần
//bằng thuật toán Bubble Sort (Nổi bọt) hoặc dùng hàm có sẵn Array.Sort().

// int[] arr = {1,3,2,4,51,6,7,8,9,12};
// Console.WriteLine("Mang truoc khi sap xep: "+ string.Join(",",arr));
// bool swap;
// int n = arr.Length;
// for ( int i =0; i < n-1; i++ )
// {
//     swap = false;
//     for (int j = 0; j < n - i - 1; j++)
//     {
//         if (arr[j] > arr[j + 1])
//         {
//             int temp = arr[j];
//             arr[j] = arr[j + 1];
//             arr[j + 1] = temp;
//             swap = true;
//         }
//     }
//     if (swap == false) break;
// }
// Console.WriteLine("Mang khi da sap xep: "+ string.Join(",",arr)); //su dung string. join de goi ra mang?

//Tìm kiếm vị trí: Nhập vào một số $x$. Kiểm tra xem $x$ có tồn tại trong mảng không?
//Nếu có, hãy chỉ ra tất cả các vị trí (index) của nó.

// int[] arr ={1,3,2,4,51,6,7,8,9,12};
// Console.WriteLine("Nhap vao mot so trong mang: ");
// int so =  Convert.ToInt32(Console.ReadLine());
// bool thoatChuongTrinh = false;
// for (int i=0;i< arr.Length;i++)
// {
//     if (arr[i].Equals(so))
//     {
//         Console.WriteLine($"Count {so} nam o vi tri so: " + (i+1));
//         thoatChuongTrinh  = true;
//         break;
//     }
// }
//
// // kiem tra xem chuong trinh co dang tra ve false khong?
// // dau "!" la phu dinh thoat chuong trinh(thoatChuongTrinh = false;)
// if (!thoatChuongTrinh)
// {
//     Console.WriteLine("Not found " + so + " in the list.");
// }

//Xóa phần tử: Nhập vào một vị trí $k$.
//Hãy xóa phần tử tại vị trí đó và cập nhật lại mảng

int[] arr ={1,3,2,4,51,6,7,8,9,12};

int n = arr.Length;

Console.Write("Nhap vao vi tri muon xoa trong mang: ");
int dele = Convert.ToInt32(Console.ReadLine());

if (dele < 0 || dele >= n)
{
    Console.WriteLine("Vi tri xoa khong hop le!");
}
else
{
    for (int i = dele; i < n-1; i++)
    {
        arr[i] = arr[i + 1];
    }

    n--;
    
    Console.Write("Mang sau khi xoa: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(arr[i] + (i == n - 1 ? "" : ", "));
    }
}



